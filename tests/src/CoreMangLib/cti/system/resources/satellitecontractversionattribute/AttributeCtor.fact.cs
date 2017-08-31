using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_resources_satellitecontractversionattribute_AttributeCtor_AttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_resources_satellitecontractversionattribute_AttributeCtor_AttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\resources\\satellitecontractversionattribute\\AttributeCtor\\AttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
