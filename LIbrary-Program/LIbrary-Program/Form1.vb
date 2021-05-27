Public Class Form1
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel_H.Show()

        Panel_Register.Visible = False
        Panel_Ad_Interface.Visible = False
        Panel_T_Interface.Visible = False
        Panel_St_Interface.Visible = False
        Panel_Login.Visible = False
        Panel_About.Visible = False
        Panel_Contact.Visible = False
        Panel_Catalog.Visible = False


        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Teacher")
        ComboBox1.Items.Add("Student")

    End Sub

    Private Sub Btn_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Home.Click
        Panel_H.Show()

        Panel_Register.Visible = False
        '        Panel_Ad_Interface.Visible = False
        Panel_Login.Visible = False
        Panel_About.Visible = False
        Panel_Contact.Visible = False
        Panel_Catalog.Visible = False
        Panel_Ad_Interface.Visible = False
        Panel_T_Interface.Visible = False
        Panel_St_Interface.Visible = False


    End Sub
#Region "New Account"
    Private Sub btn_Create_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create.Click
        Panel_Register.Show()
        Panel_H.Visible = False



    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accnt.Click
        Panel_Register.Show()
        Panel_Login.Visible = False

    End Sub
#End Region
#Region "SignUp Button"
    Private Sub btn_SignUp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SignUp.Click
        'Panel_Ad_Interface.Show()
        'Panel_T_Interface.Show()
        'Panel_St_Interface.Show()

        'Panel_Login.Show()

        If RB_Admin.Checked = True Then
            Panel_Ad_Interface.Show()
            Panel_Login.Show()

            lbl_Ad_ID.Text = "ID: " & Val(txt_ID.Text)
            lbl_Ad_Name.Text = RB_Admin.Text
            lbl_Ad_UserName.Text = (txt_Email.Text)
            lbl_Ad_Name.Text = (txt_Name.Text)

            MsgBox("Welcome! " & " " & txt_Name.Text & " " & "you have created an Admin's account" & " " & "your ID number is:" & txt_ID.Text)


        ElseIf RB_Teacher.Checked = True Then
            Panel_T_Interface.Show()
            Panel_Login.Show()

            lbl_T_ID.Text = "ID: " & Val(txt_ID.Text)
            lbl_T_Name.Text = RB_Teacher.Text
            lbl_T_UserName.Text = (txt_Email.Text)
            lbl_T_Name.Text = (txt_Name.Text)

            MsgBox("Welcome! " & " " & txt_Name.Text & " " & "you have created a Teacher's account" & " " & "your ID number is:" & txt_ID.Text)


        ElseIf RB_Student.Checked Then
            Panel_St_Interface.Show()
            Panel_Login.Show()

            lbl_St_ID.Text = "ID: " & Val(txt_ID.Text)
            lbl_St_Name.Text = RB_Student.Text
            lbl_St_UserName.Text = (txt_Email.Text)
            lbl_St_Name.Text = (txt_Name.Text)

            MsgBox("Welcome! " & " " & txt_Name.Text & " " & "you have created a Student's account" & " " & "your ID number is:" & txt_ID.Text)
        End If

    End Sub
#End Region
#Region "Login Button"
    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        'Panel_Ad_Interface.Enabled = False
        'Panel_T_Interface.Enabled = False
        'Panel_St_Interface.Enabled = False

        If ComboBox1.SelectedItem = "Admin" Then
            Panel_Ad_Interface.Enabled = True
            Panel_Ad_Interface.Show()


            Panel_T_Interface.Visible = False
            Panel_St_Interface.Visible = False

            lbl_Ad_ID.Text = "ID: " & Val(txt_Log_ID.Text)
            lbl_Ad_UserName.Text = (txt_LogUserN.Text)
            lbl_Ad_Name.Text = (txt_LogName.Text)


        ElseIf ComboBox1.SelectedItem = "Teacher" Then
            'Panel_T_Interface.Enabled = True
            Panel_Ad_Interface.Show()
            Panel_T_Interface.Show()

            Panel_St_Interface.Visible = False

            lbl_T_ID.Text = "ID: " & Val(txt_Log_ID.Text)
            lbl_T_UserName.Text = (txt_LogUserN.Text)
            lbl_T_Name.Text = (txt_LogName.Text)


        ElseIf ComboBox1.SelectedItem = "Student" Then
            Panel_St_Interface.Enabled = True
            Panel_St_Interface.Show()

            lbl_St_ID.Text = "ID: " & Val(txt_Log_ID.Text)
            lbl_St_UserName.Text = (txt_LogUserN.Text)
            lbl_St_Name.Text = (txt_LogName.Text)

        End If

    End Sub

    Private Sub btn_Login_Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login_Up.Click
        Panel_Login.Show()
        Panel_Ad_Interface.Visible = False
        Panel_T_Interface.Visible = False
        Panel_St_Interface.Visible = False
        Panel_Contact.Visible = False
        Panel_About.Visible = False
        Panel_H.Visible = False

    End Sub
#End Region

    Private Sub btn_St_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_St_Logout.Click
        Panel_Login.Show()

        txt_Log_ID.Clear()
        txt_LogUserN.Clear()
        txt_LogName.Clear()



    End Sub

    Private Sub Btn_Contact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Contact.Click
        Panel_Contact.Show()
        Panel_Contact.Visible = True
        Panel_About.Visible = False
        Panel_Login.Visible = False
        Panel_H.Visible = False
        Panel_Catalog.Visible = False
    End Sub

    Private Sub Btn_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_About.Click
        Panel_About.Show()
        Panel_About.Visible = True
        'Panel_Contact.Visible = False
        Panel_Login.Visible = False
        Panel_H.Visible = False
        Panel_Contact.Visible = False
        Panel_Catalog.Visible = False

    End Sub

 
    Private Sub Btn_Catalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Catalog.Click
        Panel_Catalog.Show()
        Panel_Catalog.Visible = True
        Panel_About.Visible = False
        'Panel_Contact.Visible = False
        Panel_H.Visible = False
        Panel_Contact.Visible = False
        Panel_Register.Visible = False
    End Sub

    Private Sub Btn_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View.Click
        MsgBox("You must Login first")
        Panel_Login.Show()
        Panel_Login.Visible = True
        Panel_Catalog.Visible = False
        Panel_Register.Visible = True
        Panel_Register.Show()

    End Sub
End Class
