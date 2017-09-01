using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _LOHCompaction_lohcompactscenariorepro_lohcompactscenariorepro_
    {
        [OuterLoop]
        [Fact]
        public void _LOHCompaction_lohcompactscenariorepro_lohcompactscenariorepro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohcompactscenariorepro\\lohcompactscenariorepro.cmd");
        }
    }
}
