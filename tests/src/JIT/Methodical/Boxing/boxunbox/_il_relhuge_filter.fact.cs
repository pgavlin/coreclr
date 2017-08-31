using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_boxunbox__il_relhuge_filter__il_relhuge_filter_
    {
        [Fact]
        public void _Boxing_boxunbox__il_relhuge_filter__il_relhuge_filter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\boxunbox\\_il_relhuge_filter\\_il_relhuge_filter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
