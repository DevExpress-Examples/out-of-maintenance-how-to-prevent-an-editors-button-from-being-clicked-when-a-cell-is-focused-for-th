# How to prevent an editor's button from being clicked when a cell is focused for the first time


<p>When you focus a row with a mouse click, an inplace-editor is immediately activated. If the mouse was above the editor's button, this button is clicked. This example illustrates how to prevent behavior alteration so that clicking a non-focused cell will focus it first, and a subsequent click activate the in-place editor.<br />
If you are using a version greater than 9.1 you can achieve the same result by setting the gridView's OptionsBehavior.EditorShowMode to the MouseDownFocused value.</p>

<br/>


