using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    public class _newarray_newarray_
    {
        [OuterLoop]
        [Fact]
        public void _newarray_newarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("readytorun\\tests\\newarray\\newarray.cmd");
        }
    }
}
