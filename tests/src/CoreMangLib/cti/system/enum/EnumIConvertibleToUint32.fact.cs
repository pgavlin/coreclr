using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIConvertibleToUint32_EnumIConvertibleToUint32_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIConvertibleToUint32_EnumIConvertibleToUint32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIConvertibleToUint32\\EnumIConvertibleToUint32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
