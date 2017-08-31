using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__il_dbgiface2__il_dbgiface2_
    {
        [Fact]
        public void _casts_iface__il_dbgiface2__il_dbgiface2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_il_dbgiface2\\_il_dbgiface2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
