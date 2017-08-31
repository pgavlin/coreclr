using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_satellitecontractversionattribute_AttributeVersion_AttributeVersion_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_satellitecontractversionattribute_AttributeVersion_AttributeVersion_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\satellitecontractversionattribute\\AttributeVersion\\AttributeVersion.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
