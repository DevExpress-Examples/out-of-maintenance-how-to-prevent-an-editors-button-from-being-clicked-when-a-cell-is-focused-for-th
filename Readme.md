<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E385)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication4/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication4/Form1.vb))
* [Program.cs](./CS/WindowsApplication4/Program.cs) (VB: [Program.vb](./VB/WindowsApplication4/Program.vb))
<!-- default file list end -->
# How to prevent an editor's button from being clicked when a cell is focused for the first time


<p>When you focus a row with a mouse click, an inplace-editor is immediately activated. If the mouse was above the editor's button, this button is clicked. This example illustrates how to prevent behavior alteration so that clicking a non-focused cell will focus it first, and a subsequent click activate the in-place editor.<br />
If you are using a version greater than 9.1 you can achieve the same result by setting the gridView's OptionsBehavior.EditorShowMode to the MouseDownFocused value.</p>

<br/>


