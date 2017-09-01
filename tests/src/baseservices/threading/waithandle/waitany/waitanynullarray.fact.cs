using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitany_waitanynullarray_waitanynullarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanynullarray_waitanynullarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanynullarray\\waitanynullarray.cmd");
        }
    }
}
