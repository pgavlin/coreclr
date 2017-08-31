using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt163_ConvertToUInt163_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt163_ConvertToUInt163_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt163\\ConvertToUInt163.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
