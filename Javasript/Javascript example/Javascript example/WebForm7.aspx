<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm7.aspx.vb" Inherits="Javascript_example.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p id="demo"></p>
            <script>
                var flowers = ["rose", "lilly", "hibiscus"];
                var nums = [10, 70, 30, 40, 50];
                
                for (i = 0; i < nums.length; i++) {
                    for (j = i + 1; j < nums.length; j++) {
                        if (nums[i] > nums[j]) {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                document.getElementById("demo").innerHTML = nums;
                document.getElementById("demo").innerHTML = flowers.toString();

                flowers.push("Jasmine");
                document.getElementById("demo").innerHTML = flowers;
            </script>
        </div>
    </form>
</body>
</html>
