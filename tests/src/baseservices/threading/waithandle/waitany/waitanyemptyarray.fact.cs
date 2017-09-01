using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanyemptyarray_waitanyemptyarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyemptyarray_waitanyemptyarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyemptyarray\\waitanyemptyarray.cmd");
        }
    }
}
