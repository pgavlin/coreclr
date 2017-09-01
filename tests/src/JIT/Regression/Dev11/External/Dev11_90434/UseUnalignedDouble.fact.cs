using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_Dev11_90434_UseUnalignedDouble_UseUnalignedDouble_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_Dev11_90434_UseUnalignedDouble_UseUnalignedDouble_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\Dev11_90434\\UseUnalignedDouble\\UseUnalignedDouble.cmd");
        }
    }
}
