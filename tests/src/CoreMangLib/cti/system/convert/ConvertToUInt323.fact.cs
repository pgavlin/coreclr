using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt323_ConvertToUInt323_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt323_ConvertToUInt323_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt323\\ConvertToUInt323.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
