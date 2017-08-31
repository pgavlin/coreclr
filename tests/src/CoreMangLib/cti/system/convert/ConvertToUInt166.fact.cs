using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt166_ConvertToUInt166_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt166_ConvertToUInt166_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt166\\ConvertToUInt166.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
