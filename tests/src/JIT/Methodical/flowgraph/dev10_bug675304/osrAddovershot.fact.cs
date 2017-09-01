using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug675304_osrAddovershot_osrAddovershot_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug675304_osrAddovershot_osrAddovershot_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug675304\\osrAddovershot\\osrAddovershot.cmd");
        }
    }
}
