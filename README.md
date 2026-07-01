# DateTime Calculator - Complete Documentation

## Project Overview

The **DateTime Calculator** is a robust Windows Forms application built with C# and .NET Framework 4.8.1 that provides comprehensive date and time calculation utilities. The application offers a user-friendly tabbed interface for performing three main types of calculations: age calculation from birth dates, date difference calculations between two dates, and time difference calculations between two times.

---

## Table of Contents

1. [Features](#features)
2. [Project Structure](#project-structure)
3. [Architecture & Design](#architecture--design)
4. [Features in Detail](#features-in-detail)
5. [Class Documentation](#class-documentation)
6. [Usage Guide](#usage-guide)
7. [Screenshots](#screenshots)
8. [Development Notes](#development-notes)
9. [Troubleshooting](#troubleshooting)

---

## Features

### Core Features

- **Age Calculator Tab**: Calculate age from birth date with results in years, months, days, hours, minutes, and seconds
- **Date Difference Calculator**: Calculate the difference between two dates with detailed breakdowns
- **Time Difference Calculator**: Calculate the difference between two times with hour, minute, and second precision
- **Input Validation**: Comprehensive date and time validation to prevent errors
- **User-Friendly Interface**: Intuitive tabbed interface with clear labeling and error messaging
- **Real-time Updates**: Dynamic label updates based on user input
- **Leap Year Support**: Accurate calculations for leap years
- **Error Handling**: Robust error handling with user-friendly error messages

---

## Project Structure

```
DateTime Calculator/
├── Program.cs                          # Application entry point
├── frmAllTabPages.cs                   # Main form (auto-generated)
├── frmAllTabPages.Designer.cs          # Form designer code
├── frmAllTabPages.resx                 # Form resources
│
├── Core Logic Classes
├── clsDateTimeCore.cs                  # Date and time core utilities
├── clsTimeCore.cs                      # Time-specific calculations (partial)
├── clsDateCore.cs                      # Date-specific calculations (partial)
├── clsTimeSpanUtils.cs                 # TimeSpan utility functions
│
├── Presentation Logic
├── clsTabPage1.cs                      # Age calculator tab logic
├── clsTabPage2.cs                      # Date difference calculator logic
├── clsTabPage3.cs                      # Time difference calculator logic
│
├── Configuration
├── App.config                          # Application configuration
├── DateTime Calculator.csproj          # Project file
├── DateTime Calculator.slnx            # Solution file
│
├── Properties/
│   ├── AssemblyInfo.cs                 # Assembly metadata
│   ├── Resources.Designer.cs           # Resource designer
│   ├── Resources.resx                  # Application resources
│   ├── Settings.Designer.cs            # Settings designer
│   └── Settings.settings               # Application settings
│
├── bin/                                # Compiled output
│   ├── Debug/                          # Debug builds
│   └── Release/                        # Release builds
│
└── obj/                                # Build intermediate files
    └── Debug/
```

---

## Architecture & Design

### Design Patterns Used

1. **Partial Classes:** Core logic split across multiple files for better organization
   - `clsDateTimeCore` split into `clsDateTimeCore.cs` (date logic) and `clsTimeCore.cs` (time logic)

2. **Static Helper Classes:** Utility classes implemented as static for global accessibility
   - `clsDateTimeCore` - Main date/time operations
   - `clsTimeSpanUtils` - TimeSpan conversion utilities

3. **Separation of Concerns:** Clear separation between:
   - **Presentation Logic** - Tab page classes handle UI interactions
   - **Business Logic** - Core classes handle calculations
   - **Utility Logic** - Helper classes provide support functions

### Component Hierarchy

```
Program.Main()
    └── Application.Run(frmAllTabPages)
        ├── Tab Page 1: Age Calculator
        │   └── clsTabPage1 (Presentation)
        │       └── clsDateTimeCore (Business Logic)
        │           └── clsTimeSpanUtils (Utilities)
        │
        ├── Tab Page 2: Date Difference
        │   └── clsTabPage2 (Presentation)
        │       └── clsDateTimeCore (Business Logic)
        │           └── clsTimeSpanUtils (Utilities)
        │
        └── Tab Page 3: Time Difference
            └── clsTabPage3 (Presentation)
                └── clsDateTimeCore (Business Logic)
```

---

## Features in Detail

### Tab 1: Age Calculator

**Purpose:** Calculate a person's age based on their birth date.

**Functionality:**

- User enters their birth date using a masked text box
- Application validates the date
- Upon clicking "Get Birth Details" button:
  - Calculates the exact age in years, months, and days
  - Calculates total hours lived
  - Calculates total minutes lived
  - Calculates total seconds lived
  - Displays all values in corresponding labels

**Input Validation:**

- Checks if date is in valid format
- Ensures birth date is not in the future
- Handles empty input gracefully

**Output Displays:**

- Years (from birth date to today)
- Months (calculated accurately accounting for varying month lengths)
- Days (remaining days not counted in months)
- Total Hours (all hours lived)
- Total Minutes (all minutes lived)
- Total Seconds (all seconds lived)

### Tab 2: Date Difference Calculator

**Purpose:** Calculate the difference between two dates.

**Functionality:**

- User selects two dates using DateTimePicker controls
- Date 1 should be earlier than Date 2
- Upon clicking "Get Details" button:
  - Validates date ordering (Date 1 < Date 2)
  - Calculates difference in days
  - Calculates accurate month count
  - Calculates year count

**Input Validation:**

- Real-time validation on date picker changes
- Ensures Date 1 is not greater than Date 2
- Displays error if validation fails

**Output Displays:**

- Days: Exact number of days between dates
- Months: Accurate month calculation accounting for variable month lengths
- Years: Full years between dates

### Tab 3: Time Difference Calculator

**Purpose:** Calculate the difference between two times.

**Functionality:**

- User selects two times using time picker controls
- Time 1 should be greater than Time 2
- Upon clicking "Calculate Difference" button:
  - Validates time ordering (Time 1 > Time 2)
  - Calculates difference in hours
  - Calculates difference in minutes
  - Calculates difference in seconds

**Input Validation:**

- Validates that Time 1 is greater than Time 2
- Displays error message if validation fails

**Output Displays:**

- Hours: Number of complete hours
- Minutes: Number of complete minutes
- Seconds: Number of complete seconds

---

## Class Documentation

### Program.cs

**Purpose:** Application entry point

**Key Methods:**

- `Main()` - Initializes the application, enables visual styles, and launches the main form

### frmAllTabPages.cs

**Purpose:** Main application form with three tabs for different calculations

**Fields:**

- `UserEnteredDateTime` - Stores birth date entered by user (Tab 1)
- `AgeBirthDetails` - TimeSpan containing age calculation (Tab 1)
- `Date1, Date2` - Dates for difference calculation (Tab 2)
- `IsValidOpeartion` - Validation flag (Tab 2)
- `dTime1, dTime2` - Times for difference calculation (Tab 3)

**Key Methods (Tab 1):**

- `UpdateAgeLabels()` - Updates all age-related labels
- `RestUserEnteredDateTime()` - Resets date and labels
- `maskedTextBox1_TextChanged()` - Validates birth date input
- `btnGetBirthDetails_Click()` - Calculate age on button click

**Key Methods (Tab 2):**

- `dateTimePicker1_ValueChanged()` - Validates date picker changes
- `UpdateLabels()` - Updates difference labels
- `DisplayDate1IsBiggerThan2Error()` - Shows validation error
- `btnGetDetailsPag2_Click()` - Calculate date difference

**Key Methods (Tab 3):**

- `RestTabPage3Labels()` - Resets time difference labels
- `UpdateTabPage3Labels()` - Updates time difference display
- `ShowTimeErrorMessage()` - Shows validation error
- `btnStartCalcDiffInTimes_Click()` - Calculate time difference

### clsDateTimeCore.cs (Main Date/Time Core Class)

**Purpose:** Core business logic for date and time calculations

**Static Methods:**

#### Date Operations

- `CheckDate(string Date, out DateTime Res)` → `bool`
  - Validates if a string represents a valid date
  - Returns: true if valid, false otherwise

- `IsValidBirthDate(DateTime DateOfBirth)` → `bool`
  - Checks if date of birth is not in the future and not default
  - Returns: true if valid birth date

- `GetDiffBetweenNowDateAndCurrentDate(DateTime Date)` → `TimeSpan`
  - Calculates difference between given date and current date
  - Returns: TimeSpan with the difference

- `GetDiffBetweenDate1AndDate2(DateTime Date1, DateTime Date2)` → `TimeSpan`
  - Calculates difference between two dates
  - Handles default dates by setting them to current time
  - Returns: TimeSpan with the difference

- `CheckDate(DateTime d1, DateTime d2)` → `bool`
  - Validates that d1 < d2
  - Returns: true if d1 is earlier than d2

- `ExtractDateFromDateTimePicker(DateTimePicker dateTimePicker)` → `string`
  - Extracts just the date part (without time) from a DateTimePicker
  - Returns: Date as string

- `UpdateDate(DateTimePicker dt, ref DateTime Date1, ref DateTime Date2)` → `void`
  - Updates Date1 or Date2 based on DateTimePicker tag
  - Uses tags "d1" and "d2" to identify which date to update

#### Time Operations (in clsTimeCore.cs partial)

- `CheckIfTime1IsBiggerThanTime2(DateTime Time1, DateTime Time2)` → `bool`
  - Compares two times (ignores date part)
  - Returns: true if Time1 is greater than Time2

- `GetDiffBetweenTime1AndTime2(DateTime Time1, DateTime Time2)` → `stTime`
  - Calculates time difference as stTime struct
  - Returns: stTime with hour, minute, second difference

**Supporting Structures:**

```csharp
internal struct stTime
{
    public int hour;      // Hours component
    public int minute;    // Minutes component
    public int second;    // Seconds component
}
```

### clsTimeSpanUtils.cs

**Purpose:** Utility functions for TimeSpan conversions and date/time calculations

**Static Methods:**

#### Month and Year Operations

- `GetNumOfDaysInMonth(byte month, int year)` → `byte`
  - Returns number of days in specified month (accounts for leap years)
  - Special handling for February in leap years

- `GetNumOfYearsFromDays(int days, DateTime StartYear)` → `int`
  - Converts days to years starting from a specific year
  - Overloaded: Also has `GetNumOfYearsFromDays(int days)` for simple calculation

- `GetNumOfMonthsFromDays(int days, DateTime StartYear)` → `int`
  - Converts days to months with accuracy
  - Accounts for varying month lengths

- `GetNumOfMonthsFromYears(int years)` → `int`
  - Converts years to months

#### Time Operations

- `GetHoursFromDays(int days)` → `int`
  - Converts days to total hours (multiplies by 24)

- `GetMinsFromDays(int days)` → `int`
  - Converts days to total minutes (multiplies by 1440)

- `GetSecsFromDays(int days)` → `int`
  - Converts days to total seconds (multiplies by 86400)

#### Helper Methods

- `NumberOfDaysInMonth(byte m)` → `byte` (Private)
  - Returns days in month using lookup array

- `IsValidMonth(int month)` → `bool` (Private)
  - Validates month is between 1-12

- `AddMonthToDate(ref DateTime StartYear)` → `void` (Private)
  - Increments a date by one month

---

## Usage Guide

### For End Users

#### Tab 1: Calculating Your Age

1. **Open the Application**
   - Launch `DateTime Calculator.exe`

2. **Navigate to Age Calculator Tab** (First tab)
   - The tab should be active by default

3. **Enter Your Birth Date**
   - Click on the masked text box labeled "Birth Date"
   - Enter your date in MM/DD/YYYY format
   - The application validates the format automatically

4. **Click "Get Birth Details" Button**
   - The application calculates your age

5. **View Results**
   - Years: Your age in complete years
   - Months: Additional months beyond complete years
   - Days: Additional days beyond months
   - Hours: Total hours you've lived
   - Minutes: Total minutes you've lived
   - Seconds: Total seconds you've lived

#### Tab 2: Calculating Date Difference

1. **Navigate to Date Difference Tab** (Second tab)

2. **Select Date 1** (Earlier Date)
   - Click on the first DateTimePicker
   - Choose the earlier date

3. **Select Date 2** (Later Date)
   - Click on the second DateTimePicker
   - Choose the later date (must be after Date 1)

4. **Click "Get Details" Button**
   - The application calculates the difference

5. **View Results**
   - Days: Number of days between dates
   - Months: Number of months between dates
   - Years: Number of years between dates

#### Tab 3: Calculating Time Difference

1. **Navigate to Time Difference Tab** (Third tab)

2. **Select Time 1** (Start Time - should be greater)
   - Click on the first time picker
   - Choose your start time

3. **Select Time 2** (End Time - should be smaller)
   - Click on the second time picker
   - Choose your end time (should be before Time 1)

4. **Click "Calculate Difference" Button**
   - The application calculates the difference

5. **View Results**
   - Hours: Hours difference
   - Minutes: Minutes difference
   - Seconds: Seconds difference

### Common Error Messages & Troubleshooting

| Error Message | Cause | Solution |
|--------------|-------|----------|
| "Wrong Date!" | Invalid date format or future date | Re-enter date in MM/DD/YYYY format and ensure it's not in the future |
| "Empty Date Or Wrong Date!" | Birth date is empty or invalid | Make sure the date is valid and not a future date |
| "Date 1 should be smaller than date 2!" | Date 1 is greater than or equal to Date 2 | Swap the dates so Date 1 is earlier |
| "Time 1 Should not Be Smaller Than Time2" | Time 1 is less than or equal to Time 2 | Ensure Time 1 is greater than Time 2 |

---

## Screenshots

The application features a clean, intuitive tabbed interface with three main calculator tabs:

- **Tab 1:** Age Calculator - Enter birth date and get detailed age breakdown
- **Tab 2:** Date Difference Calculator - Select two dates and calculate the difference
- **Tab 3:** Time Difference Calculator - Select two times and calculate the difference

---

## Development Notes

### Design Decisions

1. **Static Classes for Business Logic**
   - All calculations are static methods for easy access without instantiation
   - Allows utility functions to be used globally across the application

2. **Partial Classes for Separation**
   - `clsDateTimeCore` split across date and time operations
   - Improves code organization and maintainability

3. **TimeSpan for Duration Calculations**
   - .NET's built-in TimeSpan handles duration calculations efficiently
   - Accounts for edge cases and leap years automatically

4. **Validation at Multiple Levels**
   - UI level: Real-time validation as user types/selects
   - Business logic level: Validation before calculations

5. **User-Friendly Error Messages**
   - MessageBox dialogs inform users of validation errors
   - Encourages correct input rather than silently failing

### Performance Notes

- **Age Calculations:** O(1) - Direct arithmetic operations
- **Date Difference:** O(1) - Direct TimeSpan calculations
- **Time Difference:** O(1) - Direct time comparison
- **Month Calculations:** O(n) - Where n is number of months (typically small)

All calculations complete in milliseconds, making the application highly responsive.

---



## Troubleshooting

**Issue: Application won't start**

- Solution: Ensure .NET Framework 4.8.1 is installed
- Download from Microsoft's website if missing

**Issue: Calculation results seem incorrect**

- Solution: Verify input dates/times are in correct format
- Check that Date 1 < Date 2 and Time 1 > Time 2

**Issue: Text appears blurry on high DPI displays**

- Solution: Right-click .exe → Properties → Compatibility
- Disable fullscreen optimizations if needed
