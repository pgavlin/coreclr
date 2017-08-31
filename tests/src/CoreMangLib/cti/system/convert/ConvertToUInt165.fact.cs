using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt165_ConvertToUInt165_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt165_ConvertToUInt165_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt165\\ConvertToUInt165.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
