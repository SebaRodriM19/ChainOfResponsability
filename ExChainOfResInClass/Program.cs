using ExChainOfResInClass;
using ExChainOfResInClass.ChainOfResponsabilities;

var myInput = "1,2";
var myInput1 = "1,";
var myInput2 = "1,a";
var myInput3 = "-1,b";
var myInput4 = "-1,5";
var myInput5 = "-2,-4";

//var stringApprover = new SetUpChain().GetChain();

//Console.WriteLine(stringApprover.ProcessString(myInput));
//Console.WriteLine();
//Console.WriteLine(stringApprover.ProcessString(myInput1));
//Console.WriteLine();
//Console.WriteLine(stringApprover.ProcessString(myInput2));
//Console.WriteLine();
//Console.WriteLine(stringApprover.ProcessString(myInput3));
//Console.WriteLine();
//Console.WriteLine(stringApprover.ProcessString(myInput4));
//Console.WriteLine();
//Console.WriteLine(stringApprover.ProcessString(myInput5));

var approverUpgrade = new SetUpChainUpgrade().GetChainUpgrade();
var myInput6 = "1,3,4,2,5,6";
var myInput7 = "";

Console.WriteLine(approverUpgrade.ProcessString(myInput));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput1));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput2));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput3));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput4));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput5));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput6));
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput7));
