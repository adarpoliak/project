<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductTemplate.aspx.cs" Inherits="ProductTemplate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title></title>
    <link href="ProductCss.css" rel="stylesheet" />
    <script src="ProductJS.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <main>
        <div class="left-column"><!--product image-->
            <img src="#" data-image="option-1" alt="" class="active"/>
            <img src="#" data-image="option-2" alt=""/>
            <img src="#" data-image="option-3" alt=""/>
        </div>
        <div class="right-column">

            <div class="product-discription">
                <span></span><!--product name-->
                <h1></h1><!--product title-->
                <p></p><!--product discription-->
            </div>

            <div class="product-configuration">
                <div class="product-color">
                    <span>Color</span>
                    <select id="color-select" class="soflow">
                        <option id="defult-option">Select Color</option>
                        <option id="option-1"></option>
                        <option id="option-2"></option>
                        <option id="option-3"></option>
                    </select>
                </div><!--close product color-->
                <div class="product-price">
                    <span></span>
                    <a href="#" id="add-to-cart" class="cart-btn">Add to cart</a>
                </div>
            </div><!--close product-configuration-->

            
        </div>
    </main>
</asp:Content>

