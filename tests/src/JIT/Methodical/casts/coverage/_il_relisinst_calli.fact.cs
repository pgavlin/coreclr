using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relisinst_calli__il_relisinst_calli_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_relisinst_calli__il_relisinst_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relisinst_calli\\_il_relisinst_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
