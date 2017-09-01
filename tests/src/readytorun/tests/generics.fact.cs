using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    public class _generics_generics_
    {
        [OuterLoop]
        [Fact]
        public void _generics_generics_cmd()
        {
            CoreclrTestWrapperLib.RunTest("readytorun\\tests\\generics\\generics.cmd");
        }
    }
}
