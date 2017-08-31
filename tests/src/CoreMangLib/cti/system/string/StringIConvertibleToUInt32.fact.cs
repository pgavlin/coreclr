using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIConvertibleToUInt32_StringIConvertibleToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIConvertibleToUInt32_StringIConvertibleToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIConvertibleToUInt32\\StringIConvertibleToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
