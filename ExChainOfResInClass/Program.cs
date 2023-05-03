using ExChainOfResInClass;
using ExChainOfResInClass.ChainOfResponsabilities;

var myInput = "1,2";
var myInput1 = "1,";
var myInput2 = "1,a";
var myInput3 = "-1,b";
var myInput4 = "-1,5";
var myInput5 = "-2,-4";

//var approver = new SetUpChain().GetChain();
//Console.WriteLine(approver.ProcessString(myInput).Item2);
//Console.WriteLine();
//Console.WriteLine(approver.ProcessString(myInput1).Item2);
//Console.WriteLine();
//Console.WriteLine(approver.ProcessString(myInput2).Item2);
//Console.WriteLine();
//Console.WriteLine(approver.ProcessString(myInput3).Item2);
//Console.WriteLine();
//Console.WriteLine(approver.ProcessString(myInput4).Item2);
//Console.WriteLine();
//Console.WriteLine(approver.ProcessString(myInput5).Item2);
//Console.WriteLine();

var approverUpgrade = new SetUpChainUpgrade().GetChainUpgrade();
var myInput6 = "1,3,4,2,5,6";
var myInput7 = "";

Console.WriteLine(approverUpgrade.ProcessString(myInput).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput1).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput2).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput3).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput4).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput5).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput6).Item2);
Console.WriteLine();
Console.WriteLine(approverUpgrade.ProcessString(myInput7).Item2);
