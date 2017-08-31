using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3212_ConvertToUInt3212_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3212_ConvertToUInt3212_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3212\\ConvertToUInt3212.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
