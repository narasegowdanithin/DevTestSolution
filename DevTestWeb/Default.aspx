<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wescale.DevTestWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>WPSM Developer Test</h1>
        <p class="lead">This application is intended for testing a developer. Some bugs have been implemented and optimization possibilities have been created.</p>
        <p><a href="About" class="btn btn-primary btn-lg">More info &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Leeeet's go - or not?</h2>
            <p>
                The following form shows you what a standard form looks like in our system. Here everything is adjustable, or was it somewhere else?
            </p>
            <p>
                <a class="btn btn-default" href="UI/DefaultForm">More info &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>.NET-Remoting</h2>
            <p>
                On the following page we work with the remoting technology that we use to communicate between the web and the service.
            </p>
            <p>
                <a class="btn btn-default" href="UI/Remoting">More info&raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Database</h2>
            <p>
                On the following page you will find some database interaction with hibernate and sqllite.
            </p>
            <p>
                <a class="btn btn-default" href="UI/Database">More info &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
