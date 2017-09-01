using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_Dev11_243742_app_app_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_Dev11_243742_app_app_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\Dev11_243742\\app\\app.cmd");
        }
    }
}
