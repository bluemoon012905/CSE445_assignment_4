# CSE 445 Assignment 4: XML and JSON Processing

## About

This project is an assignment for CSE 445 that demonstrates understanding of XML, XSD, and JSON. It involves creating an XML schema (XSD), an XML document based on that schema, and a C# program to validate the XML and convert it to JSON.

## Features

- **XML Schema:** A well-defined XSD for a collection of hotels.
- **XML Data:** An XML file containing data for 10 hotels, adhering to the XSD.
- **Error XML:** A separate XML file with intentional errors for testing validation.
- **C# Program:** A C# console application that performs the following:
    - **XML Validation:** Validates the XML files against the XSD.
    - **XML to JSON Conversion:** Converts the valid XML data into a JSON format.

## Prerequisites

To compile and run this project, you will need a C# compiler that supports C# 7.0 and .NET Framework 4.7. On Linux or macOS, you can use the Mono compiler.

- **Mono:** [https://www.mono-project.com/](https://www.mono-project.com/)

## Compilation and Execution

1.  **Compile the C# code:**

    ```bash
    mcs -r:System.Xml.dll -r:Newtonsoft.Json.dll submission.cs
    ```

    *Note: You may need to install the `Newtonsoft.Json` package if you don't have it. You can do this via NuGet or by downloading the DLL.*

2.  **Run the compiled program:**

    ```bash
    mono submission.exe
    ```

## Expected Output

The program will produce the following output on the console:

1.  **Validation of `Hotels.xml`:** The program will print "No Error" to indicate that the XML is valid according to the XSD.
2.  **Validation of `HotelsErrors.xml`:** The program will print an error message detailing the first validation error found in the file.
3.  **JSON Conversion:** The program will print a JSON string representing the data from `Hotels.xml`.

