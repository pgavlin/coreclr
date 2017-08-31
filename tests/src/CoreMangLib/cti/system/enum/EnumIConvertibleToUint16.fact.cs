using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIConvertibleToUint16_EnumIConvertibleToUint16_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIConvertibleToUint16_EnumIConvertibleToUint16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIConvertibleToUint16\\EnumIConvertibleToUint16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
