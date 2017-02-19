<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyForm.aspx.cs" Inherits="UserWebApp.FamilyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id ="header">
           <h1>Home stay family application</h1>
    </div>

    <form id="form1" runat="server">
        <div>
            <%-- This is temporary until we solve session variables --%>
            <asp:Label ID="counter" Visible="false" Text="0" runat="server"></asp:Label>

            <%-- Family panel --%>
            <asp:Panel runat="server" id="familyPanel">
                
                <%--family name--%>
                <asp:Label AssociatedControlID="familyName" Text="Family Last Name" runat="server"></asp:Label>
                <asp:TextBox runat="server" id="familyName"></asp:TextBox>

                <br />
                <br />
                <asp:Label AssociatedControlID="familyCnt" Text="How many family members" runat="server"></asp:Label>
                <asp:DropDownList runat="server" ID="familyCnt" OnSelectedIndexChanged="familyCnt_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="4" Text ="4" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="5" Text ="5" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="6" Text ="6" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="7" Text ="7" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="8" Text ="8" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="9" Text ="9" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="10" Text ="10" Enabled="True"></asp:ListItem>
                </asp:DropDownList>
                
               <asp:Panel runat="server" ID="familyListPanel"></asp:Panel>


                <%-- Family Name
                
                Family members
                    -fname
                    -lname
                    -dob
                    -gender
                    -is host?--%>
                
            </asp:Panel>
            
              
            <%-- Contact info panel --%>
            <asp:Panel runat="server" id="contactInfoPanel" Enabled="False">

                <asp:Label runat="server" Text="Address" AssociatedControlID="address"></asp:Label>
                <asp:TextBox runat="server" id="address" Enabled="True"></asp:TextBox>

                <br />

                <asp:Label runat="server" Text="Primary Phone" AssociatedControlID="phone1"></asp:Label>
                <asp:TextBox runat="server" id="phone1"></asp:TextBox>

                <br />

                <asp:Label runat="server" Text="Secondary Phone" AssociatedControlID="phone2"></asp:Label>
                <asp:TextBox runat="server" id="phone2"></asp:TextBox>

                <br />

                <asp:Label runat="server" Text="Email" AssociatedControlID="email"></asp:Label>
                <asp:TextBox runat="server" id="email"></asp:TextBox>
                    
            </asp:Panel>
            
            
            <%-- living details panel --%>
            <asp:Panel runat="server" id="livingDetailsPanel" Enabled="False">

                <asp:Label runat="server" Text="Allow Smoking?" AssociatedControlID="allowSmoking"></asp:Label>
                <asp:CheckBox runat="server" ID="allowSmoking" />

                <br />

                <asp:Label runat="server" Text="Does anyone in your family smoke?" AssociatedControlID="familySmoke"></asp:Label>
                <asp:CheckBox runat="server" ID="familySmoke" />

                <br />

                <asp:Label runat="server" Text="Does anyone in your family smoke?" AssociatedControlID="allowDrinking"></asp:Label>
                <asp:CheckBox runat="server" ID="allowDrinking" />

                <br />

                <asp:Label runat="server" Text="Does anyone in your family drink?" AssociatedControlID="familyDrinking"></asp:Label>
                <asp:CheckBox runat="server" ID="familyDrinking" />

                <br />

                <asp:Label AssociatedControlID="dogs" Text="How many dogs do you own?" runat="server"></asp:Label>
                <asp:DropDownList runat="server" ID="dogs">
                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                </asp:DropDownList>

                <br />
             

                <asp:Label AssociatedControlID="cats" Text="How many cats do you own?" runat="server"></asp:Label>
                <asp:DropDownList runat="server" ID="cats">
                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                </asp:DropDownList>

                <br />
               

                <asp:Label AssociatedControlID="bathrooms" Text="How many bathrooms will your guest have access to?" runat="server"></asp:Label>
                <asp:DropDownList runat="server" ID="bathrooms">
                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                </asp:DropDownList>

                <asp:Label runat="server" Text="Is the primary bathroom shared?" AssociatedControlID="shareBathroom"></asp:Label>
                <asp:CheckBox runat="server" ID="shareBathroom" />

                <br />


                <asp:Label runat="server" Text="How can your guest trasport downtown? How long does it take approximately? What bus number? Additional details?" AssociatedControlID="transportation"></asp:Label>
                <asp:TextBox runat="server" id="transportation"></asp:TextBox>
                

                
               
            </asp:Panel>
            
            
            <%-- additional information panel --%>
            <asp:Panel runat="server" ID="moreInfoPanel" Enabled="False">
                
                <asp:Label runat="server" Text="What are some things your family enjoys doing?" AssociatedControlID="hobbies"></asp:Label>
                <asp:TextBox runat="server" id="hobbies"></asp:TextBox>

                <br />

                <asp:Label runat="server" Text="Please supply some additonal information so we can match you with the best candidate." AssociatedControlID="about"></asp:Label>
                <asp:TextBox runat="server" id="about"></asp:TextBox>

            </asp:Panel>            
            
            <br />
            <br />
            
            <asp:Button runat="server" id="backButon" OnClick="backButon_OnClick" Text="Go Back"/>
            <asp:Button runat="server" id="continueButton" OnClick="continueButton_OnClick" Text="Continue"/>

        </div>
    </form>
</body>
</html>
