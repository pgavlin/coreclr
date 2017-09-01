using CoreclrTestLib;
using Xunit;

namespace Interop_RefCharArray
{
    public class _RefCharArrayTest_RefCharArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _RefCharArrayTest_RefCharArrayTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\RefCharArray\\RefCharArrayTest\\RefCharArrayTest.cmd");
        }
    }
}
