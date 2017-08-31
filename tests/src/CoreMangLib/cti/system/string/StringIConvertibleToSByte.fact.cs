using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIConvertibleToSByte_StringIConvertibleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIConvertibleToSByte_StringIConvertibleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIConvertibleToSByte\\StringIConvertibleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
