using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohcompactscenariorepro_lohcompactscenariorepro_
    {
        [OuterLoop]
        [Fact]
        public void _LOHCompaction_lohcompactscenariorepro_lohcompactscenariorepro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactscenariorepro\\lohcompactscenariorepro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
