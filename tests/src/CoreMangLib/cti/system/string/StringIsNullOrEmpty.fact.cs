using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIsNullOrEmpty_StringIsNullOrEmpty_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIsNullOrEmpty_StringIsNullOrEmpty_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIsNullOrEmpty\\StringIsNullOrEmpty.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
