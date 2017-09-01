using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_dev11_27971_UninitializedHighWord_UninitializedHighWord_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_27971_UninitializedHighWord_UninitializedHighWord_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_27971\\UninitializedHighWord\\UninitializedHighWord.cmd");
        }
    }
}
