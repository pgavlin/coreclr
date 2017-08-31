using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__dbgjumper__dbgjumper_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__dbgjumper__dbgjumper_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_dbgjumper\\_dbgjumper.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
