using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt641_ConvertToUInt641_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt641_ConvertToUInt641_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt641\\ConvertToUInt641.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
