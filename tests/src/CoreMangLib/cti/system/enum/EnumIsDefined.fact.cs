using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_enum_EnumIsDefined_EnumIsDefined_
    {
        [OuterLoop]
        [Fact]
        public void _system_enum_EnumIsDefined_EnumIsDefined_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\enum\\EnumIsDefined\\EnumIsDefined.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
