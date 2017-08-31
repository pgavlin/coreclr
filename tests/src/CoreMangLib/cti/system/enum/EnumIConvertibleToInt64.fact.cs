using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIConvertibleToInt64_EnumIConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIConvertibleToInt64_EnumIConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIConvertibleToInt64\\EnumIConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
