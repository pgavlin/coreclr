using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_neutralresourceslanguageattribute_CultureName_CultureName_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_neutralresourceslanguageattribute_CultureName_CultureName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\neutralresourceslanguageattribute\\CultureName\\CultureName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
