using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6415_ConvertToUInt6415_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6415_ConvertToUInt6415_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6415\\ConvertToUInt6415.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
