using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _verif_sniff_fg_ver_fg_13_ver_fg_13_
    {
        [Fact]
        public void _verif_sniff_fg_ver_fg_13_ver_fg_13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\verif\\sniff\\fg\\ver_fg_13\\ver_fg_13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
