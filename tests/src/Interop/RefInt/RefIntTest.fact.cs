using CoreclrTestLib;
using Xunit;

namespace Interop_RefInt
{
    public class _RefIntTest_RefIntTest_
    {
        [OuterLoop]
        [Fact]
        public void _RefIntTest_RefIntTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\RefInt\\RefIntTest\\RefIntTest.cmd");
        }
    }
}
