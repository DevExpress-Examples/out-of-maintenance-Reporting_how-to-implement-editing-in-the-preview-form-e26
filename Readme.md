<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Form2.cs](./CS/Form2.cs) (VB: [Form2.vb](./VB/Form2.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to implement editing in the Preview Form


<p>The following example demonstrates how to edit a report's content in its Print Preview. To accomplish this task, handle the <strong>PreviewDoubleClick</strong> event of required controls, store their position and status, and then set a new value for these controls and recreate a report's document.</p>

<br/>


