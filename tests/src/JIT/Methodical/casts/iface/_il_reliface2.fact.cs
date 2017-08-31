using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__il_reliface2__il_reliface2_
    {
        [Fact]
        public void _casts_iface__il_reliface2__il_reliface2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_il_reliface2\\_il_reliface2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
