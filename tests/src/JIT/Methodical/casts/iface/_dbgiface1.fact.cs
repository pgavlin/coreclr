using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__dbgiface1__dbgiface1_
    {
        [Fact]
        public void _casts_iface__dbgiface1__dbgiface1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_dbgiface1\\_dbgiface1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
