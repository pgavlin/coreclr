using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    public class _genericsload_usegenericfield_usegenericfield_
    {
        [OuterLoop]
        [Fact]
        public void _genericsload_usegenericfield_usegenericfield_cmd()
        {
            CoreclrTestWrapperLib.RunTest("readytorun\\tests\\genericsload\\usegenericfield\\usegenericfield.cmd");
        }
    }
}
