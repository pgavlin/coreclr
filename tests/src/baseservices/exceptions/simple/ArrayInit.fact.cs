using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _simple_ArrayInit_ArrayInit_
    {
        [OuterLoop]
        [Fact]
        public void _simple_ArrayInit_ArrayInit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\ArrayInit\\ArrayInit.cmd");
        }
    }
}
