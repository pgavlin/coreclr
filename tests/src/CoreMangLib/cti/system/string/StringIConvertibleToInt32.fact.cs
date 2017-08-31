using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIConvertibleToInt32_StringIConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIConvertibleToInt32_StringIConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIConvertibleToInt32\\StringIConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
