using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_Dev11_14131_VectorForwarder_VectorForwarder_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_Dev11_14131_VectorForwarder_VectorForwarder_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\Dev11_14131\\VectorForwarder\\VectorForwarder.cmd");
        }
    }
}
