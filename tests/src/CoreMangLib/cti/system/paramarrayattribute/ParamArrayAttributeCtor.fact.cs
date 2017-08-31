using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_paramarrayattribute_ParamArrayAttributeCtor_ParamArrayAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_paramarrayattribute_ParamArrayAttributeCtor_ParamArrayAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\paramarrayattribute\\ParamArrayAttributeCtor\\ParamArrayAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
