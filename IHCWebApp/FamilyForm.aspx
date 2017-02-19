﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyForm.aspx.cs" Inherits="UserWebApp.FamilyForm" %>

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
            <asp:Label ID="familyCount" Visible="false" Text="0" runat="server"></asp:Label>


            <%-- Family panel --%>
            <asp:Panel runat="server" id="familyPanel">
                
                <%--family name--%>
                <asp:TextBox runat="server" id="familyName"></asp:TextBox>
                
               
                <asp:Button runat="server" id="removeFamilyMember" OnClick="removeFamilyMember_Click" Text="Remove Family Member"/>
                <asp:Button runat="server" id="addFamilyMember" OnClick="addFamilyMember_Click" Text="Add Family Member"/>
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
                 <%-- address 
                
                primary phone
                secondary phone
                
                email address--%>       
                
                <asp:TextBox runat="server">contactInfo</asp:TextBox>    

            </asp:Panel>
            
            
            <%-- living details panel --%>
            <asp:Panel runat="server" id="livingDetailsPanel" Enabled="False">
                <%--smoking policy - y / n
                host smoke - y / n
                drinking policy - y / n
                host drink - y / n

                pets (type, size & quanitty)
                
                student bathrooms - # bathrooms student has access to shared?
                
                travel to school - length, bus number, more details--%>
                
                <asp:TextBox runat="server">living details</asp:TextBox>    
            </asp:Panel>
            
            
            <%-- additional information panel --%>
            <asp:Panel runat="server" ID="moreInfoPanel" Enabled="False">
                
                <asp:TextBox runat="server">more info</asp:TextBox>    
                <%--Hobbies
               

                about--%>
            </asp:Panel>
            
            
            <br />
            <br />
            
            <asp:Button runat="server" id="backButon" OnClick="backButon_OnClick" Text="Go Back"/>
            <asp:Button runat="server" id="continueButton" OnClick="continueButton_OnClick" Text="Continue"/>

        </div>
    </form>
</body>
</html>
