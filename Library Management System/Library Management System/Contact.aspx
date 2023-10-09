<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Library_Management_System.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />


        <section>
        <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h1>Contact Us</h1>
               </center>
            </div>
         </div>

           <br />


         <div class="row">
            <div class="col-md-3 ">
                <img src="Images/contact2.png" width="200px" />
            </div>

              <div class="col-md-6 ">
     
                       <form>
  <div class="form-group">
    <label for="Full Name"><b><i>Name</i></b></label>
    <input type="text" class="form-control" id="Full Name" aria-describedby="full_name" placeholder="Enter your full name">
  </div>
  <div class="form-group">
    <label for="exampleInputEmail1"><b><i>Email address</i></b></label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter your email address">
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  </div>
    <label ><b><i>Your Message</i></b></label>
    <div class="form-group">
        <textarea id="area" name="xyz" rows="5" cols="70"></textarea>
  </div>
 
  <center><button type="submit" class="btn btn-primary btn-block btn-lg">Submit</button></center>
</form>
            </div>

             <div class="col-md-3 "> </div>
             </div>
            <br />
            <br />
            </div>
    </section>

    <br />
    <br />
    <br />
    <br />
  

    <br />
</asp:Content>
