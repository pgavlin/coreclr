using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Affinity_affinitizer_affinitizer_
    {
        [OuterLoop]
        [Fact]
        public void _Affinity_affinitizer_affinitizer_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Affinity\\affinitizer\\affinitizer.cmd");
        }
    }
}
