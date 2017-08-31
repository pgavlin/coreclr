using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3215_ConvertToUInt3215_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3215_ConvertToUInt3215_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3215\\ConvertToUInt3215.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
