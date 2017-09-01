using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    public class _genericsload_callgenericctor_callgenericctor_
    {
        [OuterLoop]
        [Fact]
        public void _genericsload_callgenericctor_callgenericctor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("readytorun\\tests\\genericsload\\callgenericctor\\callgenericctor.cmd");
        }
    }
}
