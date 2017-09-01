using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _simple_finally_finally_
    {
        [OuterLoop]
        [Fact]
        public void _simple_finally_finally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\finally\\finally.cmd");
        }
    }
}
