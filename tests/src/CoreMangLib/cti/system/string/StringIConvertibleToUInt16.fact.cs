using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIConvertibleToUInt16_StringIConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIConvertibleToUInt16_StringIConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIConvertibleToUInt16\\StringIConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
