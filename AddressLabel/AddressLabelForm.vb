'Noah Holloway
'RCET 2266
'Spring 2025
'Address Label

Option Strict On
Option Explicit On
Option Compare Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddressLabelForm
    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        AddressLabelGroupbox.Text = "Enter your details and click Display Label."
        FirstNameTextBox.Focus() ' Sets cursor priority to first text box
    End Sub

    ' Function to validate user input
    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String = ""

        ' Check if all fields are filled
        If FirstNameTextBox.Text = "" Then
            valid = False
            FirstNameTextBox.Focus()
            message &= "First name is required." & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            valid = False
            LastNameTextBox.Focus()
            message &= "Last name is required." & vbNewLine
        End If

        If StreetAddressTextBox.Text = "" Then
            valid = False
            StreetAddressTextBox.Focus()
            message &= "Street address is required." & vbNewLine
        End If

        If CityTextBox.Text = "" Then
            valid = False
            CityTextBox.Focus()
            message &= "City is required." & vbNewLine
        End If

        If StateTextBox.Text = "" Then
            valid = False
            StateTextBox.Focus()
            message &= "State is required." & vbNewLine
        End If

        If ZipCodeTextBox.Text = "" Then
            valid = False
            ZipCodeTextBox.Focus()
            message &= "ZIP code is required." & vbNewLine
        End If

        ' If any field is empty, show message box and return false
        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!")
        End If

        Return valid
    End Function

    ' Format the address into a string
    Sub SetFormattedAddress()
        If UserInputIsValid() Then
            Dim firstName As String = FirstNameTextBox.Text.Trim()
            Dim lastName As String = LastNameTextBox.Text.Trim()
            Dim street As String = StreetAddressTextBox.Text.Trim()
            Dim city As String = CityTextBox.Text.Trim()
            Dim state As String = StateTextBox.Text.Trim()
            Dim zip As String = ZipCodeTextBox.Text.Trim()

            ' Concatenate and display formatted address
            Dim fullName As String = $"{firstName} {lastName}"
            Dim cityStateZip As String = $"{city}, {state} {zip}"
            DisplayLabel.Text = $"{fullName}{vbCrLf}{street}{vbCrLf}{cityStateZip}"
        End If
    End Sub

    ' *****************************Event Handlerss****************************************
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        SetFormattedAddress()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults() ' Reset all fields and the display label
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() ' Closes the form
    End Sub
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults() ' Initialize form with default settings
    End Sub


End Class
